namespace project_cls.Service_layer.Dto.Bill
{
    public class BillUpdateDto
    {
        public int BillId { get; set; }

        public bool IsDone { get; set; } = false;
    }
}
