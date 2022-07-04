namespace projecteuler_Tests.T_201_300
{
    public class UnitTest_271_280
    {
        static TasksList tasksList = new TasksList();

        [Test]
        public void task_271_test()
        {
            if (tasksList.t_List.Length > 270)
                Assert.That(tasksList.t_List[270].answer(), Is.EqualTo("4617456485273129588"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_272_test()
        {
            if (tasksList.t_List.Length > 271)
                Assert.That(tasksList.t_List[271].answer(), Is.EqualTo("8495585919506151122"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_273_test()
        {
            if (tasksList.t_List.Length > 272)
                Assert.That(tasksList.t_List[272].answer(), Is.EqualTo("2032447591196869022"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_274_test()
        {
            if (tasksList.t_List.Length > 273)
                Assert.That(tasksList.t_List[273].answer(), Is.EqualTo("1601912348822"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_275_test()
        {
            if (tasksList.t_List.Length > 274)
                Assert.That(tasksList.t_List[274].answer(), Is.EqualTo("15030564"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_276_test()
        {
            if (tasksList.t_List.Length > 275)
                Assert.That(tasksList.t_List[275].answer(), Is.EqualTo("5777137137739632912"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_277_test()
        {
            if (tasksList.t_List.Length > 276)
                Assert.That(tasksList.t_List[276].answer(), Is.EqualTo("1125977393124310"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_278_test()
        {
            if (tasksList.t_List.Length > 277)
                Assert.That(tasksList.t_List[277].answer(), Is.EqualTo("1228215747273908452"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_279_test()
        {
            if (tasksList.t_List.Length > 278)
                Assert.That(tasksList.t_List[278].answer(), Is.EqualTo("416577688"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_280_test()
        {
            if (tasksList.t_List.Length > 279)
                Assert.That(tasksList.t_List[279].answer(), Is.EqualTo("430.088247"));
            else
                Assert.Ignore();
        }
    }
}
