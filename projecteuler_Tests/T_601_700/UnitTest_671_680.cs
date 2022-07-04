namespace projecteuler_Tests.T_601_700
{
    public class UnitTest_671_680
    {
        static TasksList tasksList = new TasksList();

        [Test]
        public void task_671_test()
        {
            if (tasksList.t_List.Length > 670)
                Assert.That(tasksList.t_List[670].answer(), Is.EqualTo("946106780"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_672_test()
        {
            if (tasksList.t_List.Length > 671)
                Assert.That(tasksList.t_List[671].answer(), Is.EqualTo("91627537"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_673_test()
        {
            if (tasksList.t_List.Length > 672)
                Assert.That(tasksList.t_List[672].answer(), Is.EqualTo("700325380"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_674_test()
        {
            if (tasksList.t_List.Length > 673)
                Assert.That(tasksList.t_List[673].answer(), Is.EqualTo("416678753"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_675_test()
        {
            if (tasksList.t_List.Length > 674)
                Assert.That(tasksList.t_List[674].answer(), Is.EqualTo("416146418"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_676_test()
        {
            if (tasksList.t_List.Length > 675)
                Assert.That(tasksList.t_List[675].answer(), Is.EqualTo("3562668074339584"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_677_test()
        {
            if (tasksList.t_List.Length > 676)
                Assert.That(tasksList.t_List[676].answer(), Is.EqualTo("984183023"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_678_test()
        {
            if (tasksList.t_List.Length > 677)
                Assert.That(tasksList.t_List[677].answer(), Is.EqualTo("1986065"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_679_test()
        {
            if (tasksList.t_List.Length > 678)
                Assert.That(tasksList.t_List[678].answer(), Is.EqualTo("644997092988678"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_680_test()
        {
            if (tasksList.t_List.Length > 679)
                Assert.That(tasksList.t_List[679].answer(), Is.EqualTo("563917241"));
            else
                Assert.Ignore();
        }
    }
}
