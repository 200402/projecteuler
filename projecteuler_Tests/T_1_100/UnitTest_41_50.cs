namespace projecteuler_Tests.T_1_100
{
    public class UnitTest_41_50
    {
        static TasksList tasksList = new TasksList();

        [Test]
        public void task_41_test()
        {
            if (tasksList.t_List.Length > 40)
                Assert.That(tasksList.t_List[40].answer(), Is.EqualTo("7652413"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_42_test()
        {
            if (tasksList.t_List.Length > 41)
                Assert.That(tasksList.t_List[41].answer(), Is.EqualTo("162"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_43_test()
        {
            if (tasksList.t_List.Length > 42)
                Assert.That(tasksList.t_List[42].answer(), Is.EqualTo("16695334890"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_44_test()
        {
            if (tasksList.t_List.Length > 43)
                Assert.That(tasksList.t_List[43].answer(), Is.EqualTo("5482660"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_45_test()
        {
            if (tasksList.t_List.Length > 44)
                Assert.That(tasksList.t_List[44].answer(), Is.EqualTo("1533776805"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_46_test()
        {
            if (tasksList.t_List.Length > 45)
                Assert.That(tasksList.t_List[45].answer(), Is.EqualTo("5777"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_47_test()
        {
            if (tasksList.t_List.Length > 46)
                Assert.That(tasksList.t_List[46].answer(), Is.EqualTo("134043"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_48_test()
        {
            if (tasksList.t_List.Length > 47)
                Assert.That(tasksList.t_List[47].answer(), Is.EqualTo("9110846700"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_49_test()
        {
            if (tasksList.t_List.Length > 48)
                Assert.That(tasksList.t_List[48].answer(), Is.EqualTo("296962999629"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_50_test()
        {
            if (tasksList.t_List.Length > 49)
                Assert.That(tasksList.t_List[49].answer(), Is.EqualTo("997651"));
            else
                Assert.Ignore();
        }
    }
}
