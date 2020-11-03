using System;

namespace TrelloAttachmentsDownloader
{
    public class RootCard
    {
        public string id { get; set; }
        public object address { get; set; }
        public object[] checkItemStates { get; set; }
        public bool closed { get; set; }
        public object coordinates { get; set; }
        public object creationMethod { get; set; }
        public DateTime dateLastActivity { get; set; }
        public string desc { get; set; }
        public object descData { get; set; }
        public object dueReminder { get; set; }
        public string idBoard { get; set; }
        public object[] idLabels { get; set; }
        public string idList { get; set; }
        public object[] idMembersVoted { get; set; }
        public int idShort { get; set; }
        public string idAttachmentCover { get; set; }
        public object locationName { get; set; }
        public bool manualCoverAttachment { get; set; }
        public string name { get; set; }
        public int pos { get; set; }
        public string shortLink { get; set; }
        public bool isTemplate { get; set; }
        public bool dueComplete { get; set; }
        public object due { get; set; }
        public object[] labels { get; set; }
        public string shortUrl { get; set; }
        public object start { get; set; }
        public string url { get; set; }
        public Cover cover { get; set; }
        public string[] idMembers { get; set; }
        public string email { get; set; }
        public Limits limits { get; set; }
        public Badges badges { get; set; }
        public bool subscribed { get; set; }
        public object[] idChecklists { get; set; }
        public object[] checklists { get; set; }
        public object[] customFieldItems { get; set; }
        public Member[] members { get; set; }
        public object[] pluginData { get; set; }
        public Action[] actions { get; set; }
    }

    public class Cover
    {
        public string idAttachment { get; set; }
        public object color { get; set; }
        public object idUploadedBackground { get; set; }
        public string size { get; set; }
        public string brightness { get; set; }
        public Scaled[] scaled { get; set; }
    }

    public class Scaled
    {
        public string _id { get; set; }
        public string id { get; set; }
        public bool scaled { get; set; }
        public string url { get; set; }
        public int bytes { get; set; }
        public int height { get; set; }
        public int width { get; set; }
    }

    public class Limits
    {
        public Attachments attachments { get; set; }
        public Checklists checklists { get; set; }
        public Stickers stickers { get; set; }
    }

    public class Attachments
    {
        public Percard perCard { get; set; }
    }

    public class Percard
    {
        public string status { get; set; }
        public int disableAt { get; set; }
        public int warnAt { get; set; }
    }

    public class Checklists
    {
        public Percard1 perCard { get; set; }
    }

    public class Percard1
    {
        public string status { get; set; }
        public int disableAt { get; set; }
        public int warnAt { get; set; }
    }

    public class Stickers
    {
        public Percard2 perCard { get; set; }
    }

    public class Percard2
    {
        public string status { get; set; }
        public int disableAt { get; set; }
        public int warnAt { get; set; }
    }

    public class Badges
    {
        public Attachmentsbytype attachmentsByType { get; set; }
        public bool location { get; set; }
        public int votes { get; set; }
        public bool viewingMemberVoted { get; set; }
        public bool subscribed { get; set; }
        public string fogbugz { get; set; }
        public int checkItems { get; set; }
        public int checkItemsChecked { get; set; }
        public object checkItemsEarliestDue { get; set; }
        public int comments { get; set; }
        public int attachments { get; set; }
        public bool description { get; set; }
        public object due { get; set; }
        public bool dueComplete { get; set; }
        public object start { get; set; }
    }

    public class Attachmentsbytype
    {
        public Trello trello { get; set; }
    }

    public class Trello
    {
        public int board { get; set; }
        public int card { get; set; }
    }

    public class Member
    {
        public string id { get; set; }
        public string bio { get; set; }
        public object bioData { get; set; }
        public bool confirmed { get; set; }
        public string memberType { get; set; }
        public string username { get; set; }
        public bool activityBlocked { get; set; }
        public string avatarHash { get; set; }
        public string avatarUrl { get; set; }
        public string fullName { get; set; }
        public object idEnterprise { get; set; }
        public object idEnterprisesDeactivated { get; set; }
        public string idMemberReferrer { get; set; }
        public object[] idPremOrgsAdmin { get; set; }
        public string initials { get; set; }
        public Nonpublic nonPublic { get; set; }
        public bool nonPublicAvailable { get; set; }
        public object[] products { get; set; }
        public string url { get; set; }
        public string status { get; set; }
    }

    public class Nonpublic
    {
    }

    public class Action
    {
        public string id { get; set; }
        public string idMemberCreator { get; set; }
        public Data data { get; set; }
        public string type { get; set; }
        public DateTime date { get; set; }
        public object appCreator { get; set; }
        public Limits1 limits { get; set; }
        public Membercreator memberCreator { get; set; }
        public Member2 member { get; set; }
    }

    public class Data
    {
        public Attachment attachment { get; set; }
        public Card card { get; set; }
        public List list { get; set; }
        public Board board { get; set; }
        public Old old { get; set; }
        public Listbefore listBefore { get; set; }
        public Listafter listAfter { get; set; }
        public string idMember { get; set; }
        public Member1 member { get; set; }
    }

    public class Attachment
    {
        public string id { get; set; }
        public string name { get; set; }
        public string url { get; set; }
        public string previewUrl { get; set; }
        public string previewUrl2x { get; set; }
    }

    public class Card
    {
        public string id { get; set; }
        public string name { get; set; }
        public int idShort { get; set; }
        public string shortLink { get; set; }
        public string idAttachmentCover { get; set; }
        public Cover1 cover { get; set; }
        public string idList { get; set; }
    }

    public class Cover1
    {
        public object color { get; set; }
        public string idAttachment { get; set; }
        public object idUploadedBackground { get; set; }
        public string size { get; set; }
        public string brightness { get; set; }
    }

    public class List
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Board
    {
        public string id { get; set; }
        public string name { get; set; }
        public string shortLink { get; set; }
    }

    public class Old
    {
        public string idAttachmentCover { get; set; }
        public Cover2 cover { get; set; }
        public string idList { get; set; }
    }

    public class Cover2
    {
        public object color { get; set; }
        public string idAttachment { get; set; }
        public object idUploadedBackground { get; set; }
        public string size { get; set; }
        public string brightness { get; set; }
    }

    public class Listbefore
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Listafter
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Member1
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Limits1
    {
    }

    public class Membercreator
    {
        public string id { get; set; }
        public string username { get; set; }
        public bool activityBlocked { get; set; }
        public string avatarHash { get; set; }
        public string avatarUrl { get; set; }
        public string fullName { get; set; }
        public string idMemberReferrer { get; set; }
        public string initials { get; set; }
        public Nonpublic1 nonPublic { get; set; }
        public bool nonPublicAvailable { get; set; }
    }

    public class Nonpublic1
    {
    }

    public class Member2
    {
        public string id { get; set; }
        public string username { get; set; }
        public bool activityBlocked { get; set; }
        public string avatarHash { get; set; }
        public string avatarUrl { get; set; }
        public string fullName { get; set; }
        public string idMemberReferrer { get; set; }
        public string initials { get; set; }
        public Nonpublic2 nonPublic { get; set; }
        public bool nonPublicAvailable { get; set; }
    }

    public class Nonpublic2
    {
    }

}
