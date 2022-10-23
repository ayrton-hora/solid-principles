namespace SOLID_Principles.Principles.OCP.Example1.Cohesive
{
    internal static class ProductExtension
    {
        #region Future need to change the class
        public static double ProfitMargin(this Product product)
        {
            try
            {
                var liquidProfit = product.Sale - product.Cost;

                var profitMargin = liquidProfit / product.Sale * 100;

                return Convert.ToDouble(profitMargin);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Error on calculate the profit margin: " + ex.Message);
            }
        }
        #endregion
    }
}
