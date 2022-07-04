namespace projecteuler_Tests.T_401_500
{
    public class UnitTest_441_450
    {
        static TasksList tasksList = new TasksList();

        [Test]
        public void task_441_test()
        {
            if (tasksList.t_List.Length > 440)
                Assert.That(tasksList.t_List[440].answer(), Is.EqualTo("5000088.8395"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_442_test()
        {
            if (tasksList.t_List.Length > 441)
                Assert.That(tasksList.t_List[441].answer(), Is.EqualTo("1295552661530920149"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_443_test()
        {
            if (tasksList.t_List.Length > 442)
                Assert.That(tasksList.t_List[442].answer(), Is.EqualTo("2744233049300770"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_444_test()
        {
            if (tasksList.t_List.Length > 443)
                Assert.That(tasksList.t_List[443].answer(), Is.EqualTo("1.200856722e263"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_445_test()
        {
            if (tasksList.t_List.Length > 444)
                Assert.That(tasksList.t_List[444].answer(), Is.EqualTo("659104042"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_446_test()
        {
            if (tasksList.t_List.Length > 445)
                Assert.That(tasksList.t_List[445].answer(), Is.EqualTo("907803852"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_447_test()
        {
            if (tasksList.t_List.Length > 446)
                Assert.That(tasksList.t_List[446].answer(), Is.EqualTo("530553372"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_448_test()
        {
            if (tasksList.t_List.Length > 447)
                Assert.That(tasksList.t_List[447].answer(), Is.EqualTo("106467648"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_449_test()
        {
            if (tasksList.t_List.Length > 448)
                Assert.That(tasksList.t_List[448].answer(), Is.EqualTo("103.37870096"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_450_test()
        {
            if (tasksList.t_List.Length > 449)
                Assert.That(tasksList.t_List[449].answer(), Is.EqualTo("583333163984220940"));
            else
                Assert.Ignore();
        }
    }
}
