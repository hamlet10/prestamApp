namespace PrestamApp.Domain.Entities
{
    public class DuePayment
    {
        public int DueID { get; set; }
        public int PaymentID { get; set; }

        public Due Due { get; set; }
        public Payment Payment { get; set; }


    }
}