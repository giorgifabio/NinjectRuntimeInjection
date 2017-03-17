Feature: ChatWithMessage
	In Order to demonstrate the use of stub during runtime
	as a test architect
	I want a simple Client Server Application that persist any message to the file system
	And I want 2 stabs that can be injected at runtime and change the behaviour for testing

@SimpleStub
Scenario: Use a simple stub of the file system
	When I send a message to my receiver application
	Then a different message is visualized

@FunnyStub
Scenario: Use a stub that do something funny
	When I send a message to my receiver application
	Then a funny message is visualized