using System;
using System.Collections.Generic;
using System.Text;

namespace TesterCore.Model
{
    public enum Subject 
    {
        Other,
        Math,
        English,
        Physisc
    }

    public enum TestType 
    {
        PublicTest,
        PrivateTest,
        TestWhithPassword,
        TestWhithPaiment
    }

    public enum QuestionType 
    {
        QuestionWhithCloseAns,
        QuestionWhithOpenAns
    }
         
}
