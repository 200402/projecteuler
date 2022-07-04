namespace projecteuler_Tests.T_601_700
{
    public class UnitTest_601_610
    {
        static TasksList tasksList = new TasksList();

        [Test]
        public void task_601_test()
        {
            if (tasksList.t_List.Length > 600)
                Assert.That(tasksList.t_List[600].answer(), Is.EqualTo("1617243"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_602_test()
        {
            if (tasksList.t_List.Length > 601)
                Assert.That(tasksList.t_List[601].answer(), Is.EqualTo("269496760"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_603_test()
        {
            if (tasksList.t_List.Length > 602)
                Assert.That(tasksList.t_List[602].answer(), Is.EqualTo("879476477"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_604_test()
        {
            if (tasksList.t_List.Length > 603)
                Assert.That(tasksList.t_List[603].answer(), Is.EqualTo("1398582231101"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_605_test()
        {
            if (tasksList.t_List.Length > 604)
                Assert.That(tasksList.t_List[604].answer(), Is.EqualTo("59992576"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_606_test()
        {
            if (tasksList.t_List.Length > 605)
                Assert.That(tasksList.t_List[605].answer(), Is.EqualTo("158452775"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_607_test()
        {
            if (tasksList.t_List.Length > 606)
                Assert.That(tasksList.t_List[606].answer(), Is.EqualTo("13.1265108586"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_608_test()
        {
            if (tasksList.t_List.Length > 607)
                Assert.That(tasksList.t_List[607].answer(), Is.EqualTo("439689828"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_609_test()
        {
            if (tasksList.t_List.Length > 608)
                Assert.That(tasksList.t_List[608].answer(), Is.EqualTo("172023848"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_610_test()
        {
            if (tasksList.t_List.Length > 609)
                Assert.That(tasksList.t_List[609].answer(), Is.EqualTo("319.30207833"));
            else
                Assert.Ignore();
        }
    }
}
