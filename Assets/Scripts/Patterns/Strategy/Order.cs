using JetBrains.Annotations;

namespace Patterns.Strategy
{
    public class Order
    {
        public string Customer { get; set; }

        public int Amount { get; set; }
        public string Name { get; set; }

        [CanBeNull] public string Description { get; set; }

        //TODO - будет устанавливаться за пределами, поэтому может быть null
        [CanBeNull] public IExportService ExportService { get; set; }

        public Order(string customer, int amount, string name)
        {
            Customer = customer;
            Amount = amount;
            Name = name;
            //TODO - здесь устанавливается по умолчанию, чтобы была защита от дурака
            ExportService = new CSVExportService();
        }

        public void Exort()
        {
            ExportService?.Export(this);
        }
    }
}