# Xamarin Forms Android NavigationPage problems

Effect: All pages added to the NavigationPage seem to be rendered and freezes the application. With Material Design package this will eventual crash the application (a crash has also occurred without Material Design, but it's more difficult).

Reproduce:
- Create 3 Tabs
- In Tab 1 add a NavigationPage
- Navigate some levels deep into the NavigationPage
- Go to Tab 2
- Go to Tab 3
- Go to Tab 2
- Go to Tab 1 (slow down)
- Do the "Go to Tabs" a few times. It will freeze the app and might crash.
