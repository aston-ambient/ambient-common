﻿namespace AmbientCommon.Questionaire
{
    public class RankingQuestionItem
    {
        public readonly string Label;
        public readonly double score;

        public RankingQuestionItem(string label, double score)
        {
            Label = label;
            this.score = score;
        }
    }
}
