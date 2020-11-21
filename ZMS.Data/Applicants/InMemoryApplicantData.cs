using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZMS.Domain.Applicants;

namespace ZMS.Data.Applicants
{
    public class InMemoryApplicantData : IApplicantData
    {
        readonly List<Applicant> applicants;
        readonly List<Conversation> conversations;
        public InMemoryApplicantData()
        {
            applicants = new List<Applicant>()
            {

                new Applicant { Id = 1, Name = "Dan Devine", Email = "dan.p.devine@gmail.com", PhoneNumber = "320-438-0234", AppDate = DateTime.Parse("03/05/2019"), Hired = true, Training = TrainingDates.June, JobSource = "Mitchell", Availability = "2-3 days a week, possibly a july 4th vacation, summer only maybe saturdays in fall.", Notes = "He's a great friend of mine, a real stand up guy!", Returning = false },
                new Applicant { Id = 2, Name = "Grace Gamello", Email = "gracegammello@gmail.com", PhoneNumber = "218-820-1678", AppDate = DateTime.Parse("2/18/2019"), Hired = true, Training = TrainingDates.May, JobSource = "Jared", Availability = "Full season, needs 10 days off though I don't know when (late june I think)", Notes = "Jared's Girlfriend", Returning = false },
                new Applicant { Id = 3, Name = "Dylan Wahoske", Email = "DWahoske@gmail.com", PhoneNumber = "218-821-9675", AppDate = DateTime.Parse("4/6/2019"), Hired = true, Training = TrainingDates.None, JobSource = "Website", Availability = "CLC Student, could work with us weekends through the fall.", Notes = "Quiet kid, but seems to be real nice.", Returning = true },
                new Applicant { Id = 4, Name = "Sarah Scott", Email = "Sarahlscott@me.com", PhoneNumber = "707 304 2703", AppDate = DateTime.Parse("3/5/2020"), Hired = false, Training = TrainingDates.July, JobSource = "Friend", Availability = "All her life", Notes = "would be a great guide.", Returning = false},
                new Applicant { Id = 5, Name = "Henry Scott", Email = "none", PhoneNumber = "(218) 513-8642", AppDate = DateTime.Parse("9/14/2014"), Hired = false, Training = TrainingDates.None, JobSource = "Friend", Availability = "in 13 years", Notes = "Not 18, unable to guide.", Returning = false }
            };
            conversations = new List<Conversation>()
            {
                new Conversation {Id = 1, Date = DateTime.Parse("03/05/1987"), Interview = true, Summary = "It was a great conversation", ApplicantId=4},
                new Conversation {Id = 2, Date = DateTime.Parse("09/19/2014"), Interview = true, Summary = "It was a terrible conversation", ApplicantId=1},
                new Conversation {Id = 3, Date = DateTime.Parse("09/17/2016"), Interview = true, Summary = "It was a boring conversation", ApplicantId=2},
                new Conversation {Id = 4, Date = DateTime.Parse("04/23/2018"), Interview = true, Summary = "It was a dull conversation", ApplicantId=3},
                new Conversation {Id = 5, Date = DateTime.Parse("02/14/2020"), Interview = true, Summary = "It was an interesting conversation", ApplicantId=5},
                new Conversation {Id = 6, Date = DateTime.Parse("04/24/1984"), Interview = false, Summary = "they changed their mind", ApplicantId=4},
                new Conversation {Id = 7, Date = DateTime.Parse("9/11/2001"), Interview = false, Summary = "Excited about the  job", ApplicantId=3},
                new Conversation {Id = 8, Date = DateTime.Parse("6/06/1944"), Interview = false, Summary = "got another job", ApplicantId=5},
                new Conversation {Id = 9, Date = DateTime.Parse("04/24/2033"), Interview = false, Summary = "they changed their mind, again", ApplicantId=1},
                new Conversation {Id = 10, Date = DateTime.Parse("9/11/2091"), Interview = false, Summary = "Not looking forward to the job", ApplicantId=4},
                new Conversation {Id = 11, Date = DateTime.Parse("6/06/2044"), Interview = false, Summary = "got another stupid job", ApplicantId=6},
            };
        }

        public Applicant Add(Applicant newApplicant)
        {
            applicants.Add(newApplicant);
            newApplicant.Id = applicants.Max(a => a.Id) + 1;
            return newApplicant;
        }

        public Conversation AddConversation(Conversation newConversation)
        {
            conversations.Add(newConversation);
            newConversation.Id = conversations.Max(a => a.Id) + 1;
            return newConversation;
        }

        public int Commit()
        {
            return 0;
        }

        public Applicant Delete(int id)
        {
            var applicant = applicants.FirstOrDefault(a => a.Id == id);
            if (applicant != null)
            {
                applicants.Remove(applicant);
            }
            return applicant;
        }

        public Conversation DeleteConversation(int id)
        {
            var conversation = conversations.FirstOrDefault(c => c.Id == id);
            if (conversation != null)
            {
                conversations.Remove(conversation);
            }
            return conversation;
        }

        public IEnumerable<Applicant> GetAll()
        {
            return from a in applicants
                   orderby a.AppDate
                   select a;
        }
        public Applicant GetById(int id)
        {
            return applicants.SingleOrDefault(applicants => applicants.Id == id);
        }

        public IEnumerable<Applicant> GetByTraining()
        {
            return from a in applicants
                   where a.Hired == true
                   orderby a.Training
                   select a;
        }

        public Conversation GetConversationById(int id)
        {
            return conversations.SingleOrDefault(conversations => conversations.Id == id);
        }

        public IEnumerable<Conversation> GetConversations(int id)
        {
            return from c in conversations
                   where c.ApplicantId == id
                   orderby c.Interview descending
                   select c;
        }

        public Applicant Update(Applicant updatedApplicant)
        {
            var applicant = applicants.SingleOrDefault(a => a.Id == updatedApplicant.Id);
            if (applicant != null)
            {
                applicant.Name = updatedApplicant.Name;
                applicant.Email = updatedApplicant.Email;
                applicant.PhoneNumber = updatedApplicant.PhoneNumber;
                applicant.AppDate = updatedApplicant.AppDate;
                applicant.Hired = updatedApplicant.Hired;
                applicant.Training = updatedApplicant.Training;
                applicant.JobSource = updatedApplicant.JobSource;
                applicant.Availability = updatedApplicant.Availability;
                applicant.Notes = updatedApplicant.Notes;
                applicant.Returning = updatedApplicant.Returning;
            }
            return applicant;
        }

        public Conversation UpdateConversation(Conversation updatedConversation)
        {
            var conversation = conversations.SingleOrDefault(c => c.Id == updatedConversation.Id);
            if (conversation != null)
            {
                conversation.Applicant = updatedConversation.Applicant;
                conversation.ApplicantId = updatedConversation.ApplicantId;
                conversation.Date = updatedConversation.Date;
                conversation.Summary = updatedConversation.Summary;
                conversation.Interview = updatedConversation.Interview;
            }
            return conversation;
        }
    }
}
