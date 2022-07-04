namespace projecteuler_Tests.T_601_700
{
    public class UnitTest_681_690
    {
        static TasksList tasksList = new TasksList();

        [Test]
        public void task_681_test()
        {
            if (tasksList.t_List.Length > 680)
                Assert.That(tasksList.t_List[680].answer(), Is.EqualTo("2611227421428"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_682_test()
        {
            if (tasksList.t_List.Length > 681)
                Assert.That(tasksList.t_List[681].answer(), Is.EqualTo("290872710"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_683_test()
        {
            if (tasksList.t_List.Length > 682)
                Assert.That(tasksList.t_List[682].answer(), Is.EqualTo("2.38955315e11"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_684_test()
        {
            if (tasksList.t_List.Length > 683)
                Assert.That(tasksList.t_List[683].answer(), Is.EqualTo("922058210"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_685_test()
        {
            if (tasksList.t_List.Length > 684)
                Assert.That(tasksList.t_List[684].answer(), Is.EqualTo("662878999"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_686_test()
        {
            if (tasksList.t_List.Length > 685)
                Assert.That(tasksList.t_List[685].answer(), Is.EqualTo("193060223"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_687_test()
        {
            if (tasksList.t_List.Length > 686)
                Assert.That(tasksList.t_List[686].answer(), Is.EqualTo("0.3285320869"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_688_test()
        {
            if (tasksList.t_List.Length > 687)
                Assert.That(tasksList.t_List[687].answer(), Is.EqualTo("110941813"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_689_test()
        {
            if (tasksList.t_List.Length > 688)
                Assert.That(tasksList.t_List[688].answer(), Is.EqualTo("0.56565454"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_690_test()
        {
            if (tasksList.t_List.Length > 689)
                Assert.That(tasksList.t_List[689].answer(), Is.EqualTo("415157690"));
            else
                Assert.Ignore();
        }
    }
}
