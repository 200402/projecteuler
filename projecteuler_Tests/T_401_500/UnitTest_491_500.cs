namespace projecteuler_Tests.T_401_500
{
    public class UnitTest_491_500
    {
        static TasksList tasksList = new TasksList();

        [Test]
        public void task_491_test()
        {
            if (tasksList.t_List.Length > 490)
                Assert.That(tasksList.t_List[490].answer(), Is.EqualTo("194505988824000"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_492_test()
        {
            if (tasksList.t_List.Length > 491)
                Assert.That(tasksList.t_List[491].answer(), Is.EqualTo("242586962923928"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_493_test()
        {
            if (tasksList.t_List.Length > 492)
                Assert.That(tasksList.t_List[492].answer(), Is.EqualTo("6.818741802"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_494_test()
        {
            if (tasksList.t_List.Length > 493)
                Assert.That(tasksList.t_List[493].answer(), Is.EqualTo("2880067194446832666"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_495_test()
        {
            if (tasksList.t_List.Length > 494)
                Assert.That(tasksList.t_List[494].answer(), Is.EqualTo("789107601"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_496_test()
        {
            if (tasksList.t_List.Length > 495)
                Assert.That(tasksList.t_List[495].answer(), Is.EqualTo("2042473533769142717"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_497_test()
        {
            if (tasksList.t_List.Length > 496)
                Assert.That(tasksList.t_List[496].answer(), Is.EqualTo("684901360"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_498_test()
        {
            if (tasksList.t_List.Length > 497)
                Assert.That(tasksList.t_List[497].answer(), Is.EqualTo("472294837"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_499_test()
        {
            if (tasksList.t_List.Length > 498)
                Assert.That(tasksList.t_List[498].answer(), Is.EqualTo("0.8660312"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_500_test()
        {
            if (tasksList.t_List.Length > 499)
                Assert.That(tasksList.t_List[499].answer(), Is.EqualTo("35407281"));
            else
                Assert.Ignore();
        }
    }
}
