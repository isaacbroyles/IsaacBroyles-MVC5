using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IsaacBroyles.Models;

namespace IsaacBroyles.Utilities
{
    public interface ISocialSource
    {
        IEnumerable<SocialPost> GetSocialPosts();
    }
}
