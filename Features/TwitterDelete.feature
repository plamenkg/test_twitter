Feature: TwitterDelete

@DeleteComment
Scenario: Delete comment of a tweet
	Given I have initialized my OAuth parameters
	| ApiKey                    | ApiSecretKey                                       | Token                                              | TokenSecret                                  |
	| TI0d6lhJSBlu9a0HCJ7rKo2dH | xCbHYYVWQR11YRCVybjRjdDK1iTW7tLRAUMiSDPnn9fHXAm1i0 | 1186291416273686528-CxMFEsTspn2oIWfsW3LKiflw5zW6zp | bAGDt1sgBdOm6N6718R0Mv6n2o2e0spH3u6Js9AXADxJt|

	And I have initialized my tweet client with https://api.twitter.com
	And I created a tweet with text Very original tweet
	And I replied to the tweet with comment I love it
	And I have logged into https://twitter.com with username plamenkg and password TestPassword1@
	And I have navigated to Very original tweet tweet comments
	When I delete the comment I love it
	Then it should not be present on the Home page