using System;
using System.Collections.Generic;
using System.Text;

namespace TesterCore.Model
{
    /// <summary>
    /// Предметняю область темта
    /// </summary>
    public enum Subject : byte
    {
        Other,
        Math,
        English,
        Physisc
    }

    public enum TestStatus :byte
    {
        Public,
        Private
    }

    /// <summary>
    /// 
    /// </summary>
    public enum TestType : byte
    {
        TestFree,
        TestWhithPassword,
        TestWhithPaiment
    }
    /// <summary>
    /// 
    /// </summary>
    public enum QuestionType : byte
    {
        QuestionWhithCloseAns,
        QuestionWhithOpenAns
    }
         
}
