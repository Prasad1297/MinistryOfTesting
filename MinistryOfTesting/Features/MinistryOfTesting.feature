Feature: MinistryOfTesting

A short summary of the feature

Scenario: 1.[ Verifying eligible courses for current plan]
	Given User is Ministry of testing page
	When user log in
	Then verifying elements available on page
	When User goes to the courses
	Then verifying the courses available according to the plan

Scenario: 2.[Playing the video from specific point]
	Given User is on Ministry of testing home page
	When User goes to Ask me anything section 
	And verify the video in video series
	Then User should be able to play that video

 
