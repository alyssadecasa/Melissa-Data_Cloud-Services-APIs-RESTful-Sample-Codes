using System.Runtime.Serialization;

namespace GEmail_CSharpApp
{
    /// <summary>
    /// Object class that holds the structure of the Records
    /// array from the Global Email REST Response
    /// </summary>
    [DataContract]
    class GEmailRecord
    {

        [DataMember(Name = "RecordID", IsRequired = true)]
        public string RecordID { get; set; }

        [DataMember(Name = "Results", IsRequired = true)]
        public string Results { get; set; }

        [DataMember(Name = "EmailAddress", IsRequired = true)]
        public string EmailAddress { get; set; }

        [DataMember(Name = "MailboxName", IsRequired = true)]
        public string MailboxName { get; set; }

        [DataMember(Name = "DomainName", IsRequired = true)]
        public string DomainName { get; set; }

        [DataMember(Name = "TopLevelDomain", IsRequired = true)]
        public string TopLevelDomain { get; set; }

        [DataMember(Name = "TopLevelDomainName", IsRequired = true)]
        public string TopLevelDomainName { get; set; }

        [DataMember(Name = "DateChecked", IsRequired = true)]
        public string DateChecked { get; set; }
    }
}
