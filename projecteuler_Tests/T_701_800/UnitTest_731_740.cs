namespace projecteuler_Tests.T_701_800
{
    public class UnitTest_731_740
    {
        static TasksList tasksList = new TasksList();

        [Test]
        public void task_731_test()
        {
            if (tasksList.t_List.Length > 730)
                Assert.That(tasksList.t_List[730].answer(), Is.EqualTo("6086371427"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_732_test()
        {
            if (tasksList.t_List.Length > 731)
                Assert.That(tasksList.t_List[731].answer(), Is.EqualTo("45609"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_733_test()
        {
            if (tasksList.t_List.Length > 732)
                Assert.That(tasksList.t_List[732].answer(), Is.EqualTo("574368578"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_734_test()
        {
            if (tasksList.t_List.Length > 733)
                Assert.That(tasksList.t_List[733].answer(), Is.EqualTo("557988060"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_735_test()
        {
            if (tasksList.t_List.Length > 734)
                Assert.That(tasksList.t_List[734].answer(), Is.EqualTo("174848216767932"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_736_test()
        {
            if (tasksList.t_List.Length > 735)
                Assert.That(tasksList.t_List[735].answer(), Is.EqualTo("25332747903959376"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_737_test()
        {
            if (tasksList.t_List.Length > 736)
                Assert.That(tasksList.t_List[736].answer(), Is.EqualTo("757794899"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_738_test()
        {
            if (tasksList.t_List.Length > 737)
                Assert.That(tasksList.t_List[737].answer(), Is.EqualTo("143091030"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_739_test()
        {
            if (tasksList.t_List.Length > 738)
                Assert.That(tasksList.t_List[738].answer(), Is.EqualTo("711399016"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_740_test()
        {
            if (tasksList.t_List.Length > 739)
                Assert.That(tasksList.t_List[739].answer(), Is.EqualTo("0.0189581208"));
            else
                Assert.Ignore();
        }
    }
}
