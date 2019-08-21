using System;
using System.Collections.Generic;
using System.Text;
using Humanizer;

namespace BlazorWithIdentity.Shared
{
    public class Question
    {
        public string QuestionId => $"{Text.Dehumanize()}_Question";

        public bool Required { get; set; }

        public string Text { get; set; }

        public string Description { get; set; }

        public QuestionType QuestionType { get; set; }

        public int? MaxLength { get; set; }

        public List<PossibleAnswer> PossibleAnswers { get; set; }

        public Answer Answer { get; set; }
    }

    public class Answer
    {
        public string Value { get; set; }
    }

    public class PossibleAnswer
    {
        public int Value { get; set; }

        public string Text { get; set; }
    }

    public enum QuestionType
    {
        Text,
        Number,
        List,
        YesNo,
        TrueFalse
    }
}
