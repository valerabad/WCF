using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.ServiceModel;
namespace Service
{
    [DataContract]
    public class Player
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public int Level { get; set; }   

        public Player(int id,  string firstname, string lastname, int level)
        {
            this.ID = id;
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Level = level;
        }
    }
}
