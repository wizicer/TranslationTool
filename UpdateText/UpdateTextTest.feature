Feature: UpdateTextTest
	In order to avoid silly mistakes
	As a update text tool user
	I want to be told the this tool can correctly update my translated text

Scenario: First time generate translation file
	Given I have following text in source file
	"""
	# title

	hello world

	##section1
	lorel anaditum

	## section2 -- with a long name even <span class="active">span</span> in it
	**lorel anaditum yanaghay**
	"""
	And I have following text in my translation file
	"""
	"""
	When I try to sync
	Then I should get following text in my translation file
	"""
	<!--
	# title

	hello world

	-->

	<!--
	##section1
	lorel anaditum

	-->

	<!--
	## section2 -- with a long name even <span class="active">span</span> in it
	**lorel anaditum yanaghay**
	-->
	"""

Scenario: Update translation file
	Given I have following text in source file
	"""
	# title

	hello world

	##section1

	Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.

	## section2 -- with a long name even <span class="active">span</span> in it
	**lorel anaditum yanaghay**
	"""
	And I have following text in my translation file
	"""
	# title

	hello world
	-->

	title translation

	<!--
	##section1

	abnormal things.
	-->

	section1 translation

	<!--
	## section2 -- with a long name even <span class="active">span</span> in it
	**lorel anaditum yanaghay**
	-->

	section2 translation
	"""
	When I try to sync
	Then I should get following text in my translation file
	"""
	<!--
	# title

	hello world

	-->

	title translation

	<!--
	##section1

	Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.

	-->

	section1 translation

	<!--
	## section2 -- with a long name even <span class="active">span</span> in it
	**lorel anaditum yanaghay**
	-->

	section2 translation
	"""

Scenario: update with out of order section
	Given I have following text in source file
	"""
	# title

	hello world

	## section0 which added later

	##section1
	lorel anaditum

	## section2 -- with a long name even <span class="active">span</span> in it
	**lorel anaditum yanaghay**
	"""
	And I have following text in my translation file
	"""
	<!--
	# title

	hello world
	-->

	<!--
	##section1
	lorel anaditum
	-->

	<!--
	## section2 -- with a long name even <span class="active">span</span> in it
	**lorel anaditum yanaghay**
	-->
	"""
	When I try to sync
	Then I should get following text in my translation file
	"""
	<!--
	# title

	hello world
	-->

	title translation

	<!--
	## section0 which added later
	-->

	<!--
	##section1
	lorel anaditum
	-->

	section1 translation

	<!--
	## section2 -- with a long name even <span class="active">span</span> in it
	**lorel anaditum yanaghay**
	-->

	section2 translation
	"""
	Given I have following text in source file
	"""
	# title

	hello world

	##section1

	Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.

	## section2 -- with a long name even <span class="active">span</span> in it
	**lorel anaditum yanaghay**
	"""
	When I try to sync
	Then I should get following text in my translation file
	"""
	<!--
	# title

	hello world
	-->

	title translation

	<!--
	##section1

	Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.
	-->

	section1 translation

	<!--
	## section2 -- with a long name even <span class="active">span</span> in it
	**lorel anaditum yanaghay**
	-->

	section2 translation
	"""
