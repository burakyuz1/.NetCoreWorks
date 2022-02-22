const apiUrl = "https://todo.burakakyuz.tk";

//Methods
function addToDoItem(item, prepend = false) {
  let li = $("<li/>")
    .attr("data-id", item.id)
    .addClass(item.isDone ? " done" : " undone");
  li[0].toDoItem = item;
  let input = $("<input/>")
    .attr("type", "checkbox")
    .prop("checked", item.isDone)
    .change(checkChange);
  let span = $("<span/>").text(item.name);
  let button = $("<button/>")
    .addClass("btn btn-danger btn-sm")
    .click(deleteClicked);

  let i = $("<i/>").addClass("fas fa-trash");
  button.append(i);
  li.append(input).append(span).append(button);

  if (prepend) {
    $("#todoList").prepend(li);
  } else {
    $("#todoList").append(li);
  }
}

function checkChange(event) {
  const isChecked = $(this).prop("checked");
  const li = $(this).closest("li");
  const toDoItem = li[0].toDoItem; //li'nin 0. elemenanın toDoItem propertysini alıyoruz
  toDoItem.isDone = isChecked;
  li.removeClass("done", "undone");
  li.addClass(isChecked ? "done" : "undone");
  if (isChecked) {
    $("#todoList").append(li);
  } else {
    $("#todoList").prepend(li);
  }

  $.ajax({
    type: "PUT",
    url: apiUrl + "/api/ToDoItems/" + toDoItem.id,
    contentType: "application/json",
    data: JSON.stringify(toDoItem),
    success: function (data) {},
  });
}

function deleteClicked(event) {
  const li = $(this).closest("li"); //en yakın li yi bulur. ( Parentlarından)
  const id = li.data("id"); //data- li herhangi bir attribute i yakalayabiliriz
  $.ajax({
    type: "DELETE",
    url: apiUrl + "/api/ToDoItems/" + id,
    success: function (data) {
      li.remove();
    },
  });
}

function GetTodos() {
  $.ajax({
    type: "GET",
    url: apiUrl + "/api/ToDoItems",
    success: function (data) {
      sortToDoItems(data);
      for (const item of data) {
        addToDoItem(item);
      }
    },
  });
}

function sortToDoItems(items) {
  items.sort((a, b) => a.isDone - b.isDone);
}

//Events
$("#frmNewTodo").submit(function (e) {
  // let todoName = $("#todoName").val();
  const newToDo = { name: $("#todoName").val() };

  $.ajax({
    type: "POST",
    url: apiUrl + "/api/ToDoItems",
    contentType: "application/json",
    data: JSON.stringify(newToDo),
    success: function (data) {
      addToDoItem(data, true);
      $("#todoName").val("");
    },
  });

  e.preventDefault();
});

//Initializations
GetTodos();
