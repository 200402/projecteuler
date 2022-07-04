namespace projecteuler_Tests.T_401_500
{
    public class UnitTest_411_420
    {
        static TasksList tasksList = new TasksList();

        [Test]
        public void task_411_test()
        {
            if (tasksList.t_List.Length > 410)
                Assert.That(tasksList.t_List[410].answer(), Is.EqualTo("9936352"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_412_test()
        {
            if (tasksList.t_List.Length > 411)
                Assert.That(tasksList.t_List[411].answer(), Is.EqualTo("38788800"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_413_test()
        {
            if (tasksList.t_List.Length > 412)
                Assert.That(tasksList.t_List[412].answer(), Is.EqualTo("3079418648040719"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_414_test()
        {
            if (tasksList.t_List.Length > 413)
                Assert.That(tasksList.t_List[413].answer(), Is.EqualTo("552506775824935461"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_415_test()
        {
            if (tasksList.t_List.Length > 414)
                Assert.That(tasksList.t_List[414].answer(), Is.EqualTo("55859742"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_416_test()
        {
            if (tasksList.t_List.Length > 415)
                Assert.That(tasksList.t_List[415].answer(), Is.EqualTo("898082747"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_417_test()
        {
            if (tasksList.t_List.Length > 416)
                Assert.That(tasksList.t_List[416].answer(), Is.EqualTo("446572970925740"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_418_test()
        {
            if (tasksList.t_List.Length > 417)
                Assert.That(tasksList.t_List[417].answer(), Is.EqualTo("1177163565297340320"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_419_test()
        {
            if (tasksList.t_List.Length > 418)
                Assert.That(tasksList.t_List[418].answer(), Is.EqualTo("998567458,1046245404,43363922"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_420_test()
        {
            if (tasksList.t_List.Length > 419)
                Assert.That(tasksList.t_List[419].answer(), Is.EqualTo("145159332"));
            else
                Assert.Ignore();
        }
    }
}
