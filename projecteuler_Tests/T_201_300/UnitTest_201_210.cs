namespace projecteuler_Tests.T_201_300
{
    public class UnitTest_201_210
    {
        static TasksList tasksList = new TasksList();

        [Test]
        public void task_201_test()
        {
            if (tasksList.t_List.Length > 200)
                Assert.That(tasksList.t_List[200].answer(), Is.EqualTo("115039000"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_202_test()
        {
            if (tasksList.t_List.Length > 201)
                Assert.That(tasksList.t_List[201].answer(), Is.EqualTo("1209002624"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_203_test()
        {
            if (tasksList.t_List.Length > 202)
                Assert.That(tasksList.t_List[202].answer(), Is.EqualTo("34029210557338"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_204_test()
        {
            if (tasksList.t_List.Length > 203)
                Assert.That(tasksList.t_List[203].answer(), Is.EqualTo("2944730"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_205_test()
        {
            if (tasksList.t_List.Length > 204)
                Assert.That(tasksList.t_List[204].answer(), Is.EqualTo("0.5731441"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_206_test()
        {
            if (tasksList.t_List.Length > 205)
                Assert.That(tasksList.t_List[205].answer(), Is.EqualTo("1389019170"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_207_test()
        {
            if (tasksList.t_List.Length > 206)
                Assert.That(tasksList.t_List[206].answer(), Is.EqualTo("44043947822"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_208_test()
        {
            if (tasksList.t_List.Length > 207)
                Assert.That(tasksList.t_List[207].answer(), Is.EqualTo("331951449665644800"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_209_test()
        {
            if (tasksList.t_List.Length > 208)
                Assert.That(tasksList.t_List[208].answer(), Is.EqualTo("15964587728784"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_210_test()
        {
            if (tasksList.t_List.Length > 209)
                Assert.That(tasksList.t_List[209].answer(), Is.EqualTo("1598174770174689458"));
            else
                Assert.Ignore();
        }
    }
}
