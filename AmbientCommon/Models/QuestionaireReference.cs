﻿using AmbientCommon.Questionaire;
using Newtonsoft.Json;
using System.Collections.Generic;
using static AmbientCommon.Questionaire.QuestionaireEnums;

namespace AmbientCommon.Models
{
    public class QuestionaireReference
    {
        public readonly QuestionCategories QuestionCategory;
        public readonly QuestionTypes QuestionType;
        public readonly string QuestionTitle;
        public readonly string QuestionPlaceholderText = "";
        public readonly List<string> SelectionOptions = new List<string>();
        public readonly string SelectionAltText = "";
        public List<RankingQuestionItem> RankingOptions = new List<RankingQuestionItem>();

        [JsonConstructor]
        public QuestionaireReference(QuestionCategories questionCategory, QuestionTypes questionType, string questionTitle, string questionHint, List<string> selectionOptions, string selectionAltText, List<RankingQuestionItem> rankingOptions)
            : this(questionCategory, questionType, questionTitle, questionHint, selectionOptions, selectionAltText)
        {
            RankingOptions = rankingOptions;
        }

        public QuestionaireReference(QuestionCategories questionCategory, QuestionTypes questionType, string questionTitle, string questionHint, List<string> selectionOptions, string selectionAltText)
        {
            QuestionCategory = questionCategory;
            QuestionType = questionType;
            QuestionTitle = questionTitle;
            QuestionPlaceholderText = questionHint;
            SelectionOptions = selectionOptions;
            SelectionAltText = selectionAltText;
        }

        public QuestionaireReference(QuestionCategories questionCategory, QuestionTypes questionType, string questionTitle, string questionHint, List<RankingQuestionItem> rankingOptions)
        {
            QuestionCategory = questionCategory;
            QuestionType = questionType;
            QuestionTitle = questionTitle;
            QuestionPlaceholderText = questionHint;
            RankingOptions = rankingOptions;
        }

        public QuestionaireReference(QuestionCategories questionCategory, QuestionTypes questionType, string questionTitle, string questionHint)
        {
            QuestionCategory = questionCategory;
            QuestionType = questionType;
            QuestionTitle = questionTitle;
            QuestionPlaceholderText = questionHint;
        }

        public QuestionaireReference(QuestionCategories questionCategory, QuestionTypes questionType, string questionTitle)
        {
            QuestionCategory = questionCategory;
            QuestionType = questionType;
            QuestionTitle = questionTitle;
        }
    }
}