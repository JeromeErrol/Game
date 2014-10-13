
public class TestResult{
	public string testName;
	public bool result;
	public string message;
	
	public TestResult(string testName, bool result, string message){
		this.testName = testName;
		this.result = result;
		this.message = message;
	}			
}