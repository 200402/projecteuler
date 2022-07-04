namespace projecteuler_Tests.T_201_300
{
    public class UnitTest_251_260
    {
        static TasksList tasksList = new TasksList();

        [Test]
        public void task_251_test()
        {
            if (tasksList.t_List.Length > 250)
                Assert.That(tasksList.t_List[250].answer(), Is.EqualTo("18946051"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_252_test()
        {
            if (tasksList.t_List.Length > 251)
                Assert.That(tasksList.t_List[251].answer(), Is.EqualTo("104924.0"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_253_test()
        {
            if (tasksList.t_List.Length > 252)
                Assert.That(tasksList.t_List[252].answer(), Is.EqualTo("11.492847"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_254_test()
        {
            if (tasksList.t_List.Length > 253)
                Assert.That(tasksList.t_List[253].answer(), Is.EqualTo("8184523820510"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_255_test()
        {
            if (tasksList.t_List.Length > 254)
                Assert.That(tasksList.t_List[254].answer(), Is.EqualTo("4.4474011180"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_256_test()
        {
            if (tasksList.t_List.Length > 255)
                Assert.That(tasksList.t_List[255].answer(), Is.EqualTo("85765680"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_257_test()
        {
            if (tasksList.t_List.Length > 256)
                Assert.That(tasksList.t_List[256].answer(), Is.EqualTo("139012411"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_258_test()
        {
            if (tasksList.t_List.Length > 257)
                Assert.That(tasksList.t_List[257].answer(), Is.EqualTo("12747994"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_259_test()
        {
            if (tasksList.t_List.Length > 258)
                Assert.That(tasksList.t_List[258].answer(), Is.EqualTo("20101196798"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_260_test()
        {
            if (tasksList.t_List.Length > 259)
                Assert.That(tasksList.t_List[259].answer(), Is.EqualTo("167542057"));
            else
                Assert.Ignore();
        }
    }
}
