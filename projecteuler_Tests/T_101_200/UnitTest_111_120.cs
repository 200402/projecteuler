namespace projecteuler_Tests.T_101_200
{
    public class UnitTest_111_120
    {
        static TasksList tasksList = new TasksList();

        [Test]
        public void task_111_test()
        {
            if (tasksList.t_List.Length > 110)
                Assert.That(tasksList.t_List[110].answer(), Is.EqualTo("612407567715"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_112_test()
        {
            if (tasksList.t_List.Length > 111)
                Assert.That(tasksList.t_List[111].answer(), Is.EqualTo("1587000"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_113_test()
        {
            if (tasksList.t_List.Length > 112)
                Assert.That(tasksList.t_List[112].answer(), Is.EqualTo("51161058134250"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_114_test()
        {
            if (tasksList.t_List.Length > 113)
                Assert.That(tasksList.t_List[113].answer(), Is.EqualTo("16475640049"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_115_test()
        {
            if (tasksList.t_List.Length > 114)
                Assert.That(tasksList.t_List[114].answer(), Is.EqualTo("168"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_116_test()
        {
            if (tasksList.t_List.Length > 115)
                Assert.That(tasksList.t_List[115].answer(), Is.EqualTo("20492570929"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_117_test()
        {
            if (tasksList.t_List.Length > 116)
                Assert.That(tasksList.t_List[116].answer(), Is.EqualTo("100808458960497"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_118_test()
        {
            if (tasksList.t_List.Length > 117)
                Assert.That(tasksList.t_List[117].answer(), Is.EqualTo("44680"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_119_test()
        {
            if (tasksList.t_List.Length > 118)
                Assert.That(tasksList.t_List[118].answer(), Is.EqualTo("248155780267521"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_120_test()
        {
            if (tasksList.t_List.Length > 119)
                Assert.That(tasksList.t_List[119].answer(), Is.EqualTo("333082500"));
            else
                Assert.Ignore();
        }
    }
}
