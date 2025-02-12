using System.Collections;
using UnityEngine.TestTools.TestRunner;

namespace UnityEditor.TestTools.TestRunner.TestRun.Tasks.Events
{
    internal class CreateEventsTask : TestTaskBase
    {
        public CreateEventsTask()
        {
            RerunAfterResume = true;
        }
        
        public override IEnumerator Execute(TestJobData testJobData)
        {
            testJobData.RunStartedEvent = new RunStartedEvent();
            testJobData.TestStartedEvent = new TestStartedEvent();
            testJobData.TestFinishedEvent = new TestFinishedEvent();
            testJobData.RunFinishedEvent = new RunFinishedEvent();
            yield break;
        }
    }
}