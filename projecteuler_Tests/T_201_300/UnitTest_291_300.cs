namespace projecteuler_Tests.T_201_300
{
    public class UnitTest_291_300
    {
        static TasksList tasksList = new TasksList();

        [Test]
        public void task_291_test()
        {
            if (tasksList.t_List.Length > 290)
                Assert.That(tasksList.t_List[290].answer(), Is.EqualTo("4037526"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_292_test()
        {
            if (tasksList.t_List.Length > 291)
                Assert.That(tasksList.t_List[291].answer(), Is.EqualTo("3600060866"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_293_test()
        {
            if (tasksList.t_List.Length > 292)
                Assert.That(tasksList.t_List[292].answer(), Is.EqualTo("2209"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_294_test()
        {
            if (tasksList.t_List.Length > 293)
                Assert.That(tasksList.t_List[293].answer(), Is.EqualTo("789184709"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_295_test()
        {
            if (tasksList.t_List.Length > 294)
                Assert.That(tasksList.t_List[294].answer(), Is.EqualTo("4884650818"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_296_test()
        {
            if (tasksList.t_List.Length > 295)
                Assert.That(tasksList.t_List[295].answer(), Is.EqualTo("1137208419"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_297_test()
        {
            if (tasksList.t_List.Length > 296)
                Assert.That(tasksList.t_List[296].answer(), Is.EqualTo("2252639041804718029"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_298_test()
        {
            if (tasksList.t_List.Length > 297)
                Assert.That(tasksList.t_List[297].answer(), Is.EqualTo("1.76882294"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_299_test()
        {
            if (tasksList.t_List.Length > 298)
                Assert.That(tasksList.t_List[298].answer(), Is.EqualTo("549936643"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_300_test()
        {
            if (tasksList.t_List.Length > 299)
                Assert.That(tasksList.t_List[299].answer(), Is.EqualTo("8.0540771484375"));
            else
                Assert.Ignore();
        }
    }
}
