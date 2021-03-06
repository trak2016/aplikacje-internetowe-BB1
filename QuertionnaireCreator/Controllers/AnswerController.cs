﻿using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuertionnaireCreator.Controllers
{
    public class AnswerController : BaseController
    {
        // GET: Answer
        public JsonResult Save(int optionId, int questionId)
        {
            var answer = new Answer()
             {
                 OptionId = optionId,
                 QuestionId = questionId
             };

            var result = _unitOfWork.AnswerRepository.Add(answer);

            return Json(result);
        }

        public JsonResult IncrementRespondendsNumber(int id)
        {
            _unitOfWork.QuestionareRepository.IncrementQuestionareNumber(id);

            return Json("");
        }
    }
}