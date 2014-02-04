using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IsaacBroyles.Utilities;
using IsaacBroyles.Models;

namespace IsaacBroyles.Repositories
{
    public class SocialRepository
    {
        private readonly IEnumerable<ISocialSource> _socialSources;

        public SocialRepository(IEnumerable<ISocialSource> socialSources)
        {
            _socialSources = socialSources;
        }

        public IEnumerable<SocialPost> GetSocialPosts()
        {
            return _socialSources.SelectMany<ISocialSource, SocialPost>(socialSource => socialSource.GetSocialPosts());
        }
    }
}