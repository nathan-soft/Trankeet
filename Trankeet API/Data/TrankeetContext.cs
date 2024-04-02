using Microsoft.EntityFrameworkCore;
using Trankeet_API.Models;

namespace Trankeet_API.Data
{
    public class TrankeetContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseEnrollment> CourseEnrollments { get; set; }
        public DbSet<Mentorship> Mentorships { get; set; }
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<PostComment> PostComments { get; set; }
        public DbSet<CourseMaterial> CourseMaterials { get; set; }
        public DbSet<MentorshipFeedback> MentorshipFeedbacks { get; set; }
        public DbSet<AdminActionLog> AdminActionLogs { get; set; }
        public DbSet<CourseReview> CourseReviews { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<ChatMsg> ChatMsgs { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<SubscriptionPlan> SubscriptionPlans { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<UserAnalytics> UserAnalytics { get; set; }
        public DbSet<UserSettings> UserSettings { get; set; }

    }
}
