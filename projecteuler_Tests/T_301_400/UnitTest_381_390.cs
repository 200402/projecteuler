namespace projecteuler_Tests.T_301_400
{
    public class UnitTest_381_390
    {
        static TasksList tasksList = new TasksList();

        [Test]
        public void task_381_test()
        {
            if (tasksList.t_List.Length > 380)
                Assert.That(tasksList.t_List[380].answer(), Is.EqualTo("139602943319822"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_382_test()
        {
            if (tasksList.t_List.Length > 381)
                Assert.That(tasksList.t_List[381].answer(), Is.EqualTo("697003956"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_383_test()
        {
            if (tasksList.t_List.Length > 382)
                Assert.That(tasksList.t_List[382].answer(), Is.EqualTo("22173624649806"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_384_test()
        {
            if (tasksList.t_List.Length > 383)
                Assert.That(tasksList.t_List[383].answer(), Is.EqualTo("3354706415856332783"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_385_test()
        {
            if (tasksList.t_List.Length > 384)
                Assert.That(tasksList.t_List[384].answer(), Is.EqualTo("3776957309612153700"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_386_test()
        {
            if (tasksList.t_List.Length > 385)
                Assert.That(tasksList.t_List[385].answer(), Is.EqualTo("528755790"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_387_test()
        {
            if (tasksList.t_List.Length > 386)
                Assert.That(tasksList.t_List[386].answer(), Is.EqualTo("696067597313468"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_388_test()
        {
            if (tasksList.t_List.Length > 387)
                Assert.That(tasksList.t_List[387].answer(), Is.EqualTo("831907372805129931"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_389_test()
        {
            if (tasksList.t_List.Length > 388)
                Assert.That(tasksList.t_List[388].answer(), Is.EqualTo("2406376.3623"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_390_test()
        {
            if (tasksList.t_List.Length > 389)
                Assert.That(tasksList.t_List[389].answer(), Is.EqualTo("2919133642971"));
            else
                Assert.Ignore();
        }
    }
}
