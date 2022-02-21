const apiUrl = "https://localhost:5001";

//Methods
function addToDoItem(item) {
  let li = $("<li/>").attr("data-id", item.id);
  let input = $("<input/>").attr("type", "checkbox");
  let span = $("<span/>").text(item.name);
  let button = $("<button/>").addClass("btn btn-danger btn-sm");
  let i = $("<i/>").addClass("fas fa-trash");
  button.append(i);
  li.append(input).append(span).append(button);
  $("#todoList").append(li);
}

function GetTodos() {
  $.ajax({
    type: "GET",
    url: apiUrl + "/api/ToDoItems",
    success: function (data) {
      for (const item of data) {
        addToDoItem(item);
      }
    },
  });
}

//Events
$("#frmNewTodo").submit(function (e) {
    // let todoName = $("#todoName").val();
    const newToDo = {name: $("#todoName").val()};

 $.ajax({
    type: "POST",
    url: apiUrl + "/api/ToDoItems",
    contentType: 'application/json',
    data: JSON.stringify(newToDo),
    success: function (data) {
      addToDoItem(data);
    },
  });
    
  
    e.preventDefault();
});

//Initializations
GetTodos();
