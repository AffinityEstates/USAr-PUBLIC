/*
    Effective Date: January 1, 2023.

    Affinity and its subsidiaries and affiliates (collectively, “Affinity”, “us” or “we”) understand that your privacy is important to you. We are committed to respecting your privacy and protecting your personal data, which is any information that is capable of identifying you as an individual person. 
    This Privacy Policy describes how we handle and protect your personal data in connection with Affinity's business activities, like conferences and events, and client services, and on websites, applications, and communications that post a link 
    to this Privacy Policy (collectively, “the Sites”), in our capacity as data controllers.
 * */

namespace AffinityWinFormsG8App.Models
{
    public class AffinityUser
    {
        public int UserId { get; set; }
        public String? UserName { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; } = null!;
    }
}
