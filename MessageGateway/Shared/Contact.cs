namespace MessageGateway.Shared
{
    public class Contact
    {
        public int contactId { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }

        public string telephone { get; set; }
        public int contractGroupId { get; set; }
        public ContactGroup contactGroupName { get; set; }
    }
}
