using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZMS.Data.Migrations;
using ZMS.Domain.Applicants;
using Microsoft.EntityFrameworkCore;

namespace ZMS.Data.Applicants
{
    public class SqlApplicantData : IApplicantData
    {
        private readonly ApplicantDbContext db;
        public SqlApplicantData(ApplicantDbContext db)
        {
            this.db = db;
        }

        public Applicant Add(Applicant newApplicant)
        {
            db.Add(newApplicant);
            return newApplicant;
        }

        public Conversation AddConversation(Conversation newConversation)
        {
            db.Add(newConversation);
            return newConversation;
        }

        public int Commit()
        {
            return db.SaveChanges();
        }

        public Applicant Delete(int id)
        {
            var applicant = GetById(id);
            if (applicant != null)
            { db.Remove(applicant); }
            return applicant;
        }

        public Conversation DeleteConversation(int id)
        {
            var conversation = GetConversationById(id);
            if (conversation != null)
            { db.Remove(conversation); }
            return conversation;
        }

        public IEnumerable<Applicant> GetAll()
        {
            var query = from a in db.Applicants
                        orderby a.AppDate
                        select a;
            return query;
        }

        public Applicant GetById(int id)
        {
            return db.Applicants.Find(id);
        }

        public IEnumerable<Applicant> GetByTraining()
        {
            var query = from a in db.Applicants
                        where a.Hired == true
                        orderby a.Training
                        select a;
            return query;
        }

        public Conversation GetConversationById(int id)
        {
            return db.Conversations.Find(id);
        }

        public IEnumerable<Conversation> GetConversations(int id)
        {
            var query = from c in db.Conversations
                        where c.Applicant.Id == id
                       orderby c.Interview descending
                       select c;
            return query;
        }

        public Applicant Update(Applicant updatedApplicant)
        {
            var entity = db.Applicants.Attach(updatedApplicant);
            entity.State = EntityState.Modified;
            return updatedApplicant;

        }

        public Conversation UpdateConversation(Conversation updatedConversation)
        {
            var entity = db.Conversations.Attach(updatedConversation);
            entity.State = EntityState.Modified;
            return updatedConversation;
        }
    }
}
