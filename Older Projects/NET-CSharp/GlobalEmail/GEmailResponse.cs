using System.Runtime.Serialization;

namespace GEmail_CSharpApp
{
    /// <summary>
    /// Object class that holds the structure of the Global Email
    /// REST response
    /// </summary>
    [DataContract]
    class GEmailResponse
    {

        [DataMember(Name = "Version", IsRequired = true)]
        public string Version { get; set; }

        [DataMember(Name = "TransmissionReference", IsRequired = true)]
        public string TransmissionReference { get; set; }

        [DataMember(Name = "TransmissionResults", IsRequired = true)]
        public string TransmissionResults { get; set; }

        [DataMember(Name = "TotalRecords", IsRequired = true)]
        public string TotalRecords { get; set; }

        [DataMember(Name = "Records", IsRequired = false)]
        public GEmailRecord[] Records { get; set; }
    }
}
