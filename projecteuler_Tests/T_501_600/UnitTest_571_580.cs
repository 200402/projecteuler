namespace projecteuler_Tests.T_501_600
{
    public class UnitTest_571_580
    {
        static TasksList tasksList = new TasksList();

        [Test]
        public void task_571_test()
        {
            if (tasksList.t_List.Length > 570)
                Assert.That(tasksList.t_List[570].answer(), Is.EqualTo("30510390701978"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_572_test()
        {
            if (tasksList.t_List.Length > 571)
                Assert.That(tasksList.t_List[571].answer(), Is.EqualTo("19737656"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_573_test()
        {
            if (tasksList.t_List.Length > 572)
                Assert.That(tasksList.t_List[572].answer(), Is.EqualTo("1252.9809"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_574_test()
        {
            if (tasksList.t_List.Length > 573)
                Assert.That(tasksList.t_List[573].answer(), Is.EqualTo("5780447552057000454"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_575_test()
        {
            if (tasksList.t_List.Length > 574)
                Assert.That(tasksList.t_List[574].answer(), Is.EqualTo("0.000989640561"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_576_test()
        {
            if (tasksList.t_List.Length > 575)
                Assert.That(tasksList.t_List[575].answer(), Is.EqualTo("344457.5871"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_577_test()
        {
            if (tasksList.t_List.Length > 576)
                Assert.That(tasksList.t_List[576].answer(), Is.EqualTo("265695031399260211"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_578_test()
        {
            if (tasksList.t_List.Length > 577)
                Assert.That(tasksList.t_List[577].answer(), Is.EqualTo("9219696799346"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_579_test()
        {
            if (tasksList.t_List.Length > 578)
                Assert.That(tasksList.t_List[578].answer(), Is.EqualTo("3805524"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_580_test()
        {
            if (tasksList.t_List.Length > 579)
                Assert.That(tasksList.t_List[579].answer(), Is.EqualTo("2327213148095366"));
            else
                Assert.Ignore();
        }
    }
}
