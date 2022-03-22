using AmbientCommon.Questionaire;
using System.Collections.Generic;
using static AmbientCommon.Questionaire.QuestionaireEnums;

namespace AmbientCommon.Models
{
    public class QuestionaireReference : BaseModel
    {
        public long Id { get; set; }
        public QuestionCategories QuestionCategory { get; set; }
        public QuestionTypes QuestionType { get; set; }
        public string QuestionTitle { get; set; }
        public string QuestionPlaceholderText { get; set; } = "";
        public List<string> SelectionOptions { get; set; } = new List<string>();
        public string SelectionAltText { get; set; } = "";
        public List<RankingQuestionItem> RankingOptions { get; set; } = new List<RankingQuestionItem>();

        public long GameConfigurationId { get; set; }
        public GameConfiguration GameConfiguration { get; set; }

        public QuestionaireReference()
        {
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
