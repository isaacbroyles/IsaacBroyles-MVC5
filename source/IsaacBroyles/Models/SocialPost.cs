using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IsaacBroyles.Utilities;

namespace IsaacBroyles.Models
{
    public class SocialPost
    {
        public Source Source { get; set; }
        public DateTime DateCreated { get; set; }
        public string Content { get; set; }


        public enum Source
        {
            Twitter
        }
    }
}