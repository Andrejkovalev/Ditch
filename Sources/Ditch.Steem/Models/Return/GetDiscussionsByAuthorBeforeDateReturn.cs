using Ditch.Steem.Models.Other;
using Newtonsoft.Json;

namespace Ditch.Steem.Models.Return
{
    /// <summary>
    /// get_discussions_by_author_before_date_return
    /// libraries\plugins\apis\tags_api\include\steem\plugins\tags_api\tags_api.hpp
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public partial class GetDiscussionsByAuthorBeforeDateReturn : DiscussionQueryResult
    {
    }
}
