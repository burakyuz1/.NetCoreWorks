namespace BizimMarket.HelperMethods
{
    public static class ActiveHelper
    {
        public static string Active(int? categoryId, int? categoryModelId)
        {
            return categoryId == categoryModelId ? "active" : "";
        }
    }
}
