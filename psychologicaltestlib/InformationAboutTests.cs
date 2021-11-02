﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psychologicaltestlib
{
    public class InformaitionAboutTests
    {
        public InformaitionAboutTests() { }
        public readonly string[] TestNames = {
                "Дианостика мотивационной структуры личности",
                "Личностные творческие характеристики" };
        public readonly string[] TestDescription = {
            //Дианостика мотивационной структуры личности
            "Автор В. Э. Мильман. Методика позволяет выявлять некоторые устойчивые тенденции личности: " +
                "общую и творческую активность, стремление к общению, обеспечению комфорта и социального " +
                "статуса и др. На основе всех ответов можно составить суждение о рабочей (деловой) и " +
                "общежитейской направленности личности.",
            //Личностные творческие характеристики
            "Предложенный тест позволяет вам выявить, насколько творческой личностью вы себя считаете."};
        public readonly string[] TestInstruction = {
            //Дианостика мотивационной структуры личности
            "Вам будет представлено 14 утверждений, касающихся жизненных устремлений и некоторых сторон " +
                "образа жизни человека. Просим вас высказать отношение к ним по каждому из 8 вариантов ответов, " +
                "проставив одну из следующих оценок каждого утверждения: «согласен с этим», «когда как», «нет, " +
                "не согласен», «не знаю». Старайтесь отвечать быстро, не задумывайтесь долго над ответами. На " +
                "всю работу у вас должно уйти не более 20 минут.",
            //Личностные творческие характеристики
            "В тесте вам будет представлено 50 утверждений. Просим вас высказать отношение по каждому из них, " +
                "выбрав одну из следующих оценок: «Согласен», «Согласен отчасти», «Затрудняюсь с ответом» или «Не " +
                "согласен» . Старайтесь отвечать быстро, не задумывайтесь долго над ответами. Выполнение теста " +
                "не ограничено по времени."};
    }
}
