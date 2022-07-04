using projecteuler;

namespace projecteuler_Tests
{
    public class Tests
    {
        static TasksList tasksList = new TasksList();

        [Test]
        public void task_1_test()
        {
            Assert.That(tasksList.t_List[0].answer(), Is.EqualTo("233168"));
        }

        [Test]
        public void task_2_test()
        {
            Assert.That(tasksList.t_List[1].answer(), Is.EqualTo("4613732"));
        }

        [Test]
        public void task_3_test()
        {
            Assert.That(tasksList.t_List[2].answer(), Is.EqualTo("6857"));
        }

        [Test]
        public void task_4_test()
        {
            Assert.That(tasksList.t_List[3].answer(), Is.EqualTo("906609"));
        }

        [Test]
        public void task_5_test()
        {
            Assert.That(tasksList.t_List[4].answer(), Is.EqualTo("232792560"));
        }

        [Test]
        public void task_6_test()
        {
            Assert.That(tasksList.t_List[5].answer(), Is.EqualTo("25164150"));
        }

        [Test]
        public void task_7_test()
        {
            Assert.That(tasksList.t_List[6].answer(), Is.EqualTo("104743"));
        }

        [Test]
        public void task_8_test()
        {
            Assert.That(tasksList.t_List[7].answer(), Is.EqualTo("23514624000"));
        }

        [Test]
        public void task_9_test()
        {
            if (tasksList.t_List.Length > 8)
                Assert.That(tasksList.t_List[8].answer(), Is.EqualTo("31875000"));
            else
                Assert.Ignore();
        }
    }
}