﻿using StackOverflowProject.DomainModels;
using StackOverflowProject.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflowProject.Repositories
{
    public class QuestionRepository : IQuestionRepository
    {

        StackOverflowDatabaseDbContext db;

        public QuestionRepository()
        {
            db = new StackOverflowDatabaseDbContext();
        }

        public void InsertQuestion(Question q)
        {
            db.Questions.Add(q);
            db.SaveChanges();
        }

        public void UpdateQuestionDetails(Question q)
        {
            Question qt = db.Questions.Where(temp => temp.QuestionID == q.QuestionID).FirstOrDefault();
            if (qt != null)
            {
                qt.QuestionName = q.QuestionName;
                qt.QuestionDateAndTime = q.QuestionDateAndTime;
                qt.CategoryID = q.CategoryID;
                db.SaveChanges();
            }
            
        }

        public void UpdateQuestionVotesCount(int qid, int value)
        {
            Question qt = db.Questions.Where(temp => temp.QuestionID == qid).FirstOrDefault();
            if (qt != null)
            {
                qt.VotesCount += value;
                db.SaveChanges();
            }
        }

        public void UpdateQuestionAnswersCount(int qid, int value)
        {
            Question qt = db.Questions.Where(temp => temp.QuestionID == qid).FirstOrDefault();
            if (qt != null)
            {
                qt.AnswersCount += value;
                db.SaveChanges();
            }
        }

        public void UpdateQuestionViewsCount(int qid, int value)
        {
            Question qt = db.Questions.Where(temp => temp.QuestionID == qid).FirstOrDefault();
            if (qt != null)
            {
                qt.ViewsCount += value;
                db.SaveChanges();
            }
        }

        public void DeleteQuestion(int qid)
        {
            Question qt = db.Questions.Where(temp => temp.QuestionID == qid).FirstOrDefault();
            if (qt != null)
            {
                db.Questions.Remove(qt);
                db.SaveChanges();
            }
        }

        public List<Question> GetQuestions()
        {
            List<Question> qt = db.Questions.OrderByDescending(temp => temp.QuestionDateAndTime).ToList();
            return qt;   
        }

        public List<Question> GetQuestionsByID(int QuestionID)
        {
            List<Question> qt = db.Questions.Where(temp => temp.QuestionID == QuestionID).ToList();
            return qt;
        }
    }
}