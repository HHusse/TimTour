import { StatusBar } from "expo-status-bar";
import { StyleSheet, Text, View } from "react-native";
import { NavigationContainer } from "@react-navigation/native";
import { createStackNavigator } from "@react-navigation/stack";
import { GlobalProvider } from "./src/context/GlobalContext";
import HomeScreen from "./src/pages/Homepage";
import DetailsScreen from "./src/pages/DetailsPage";
import LoadingPage from "./src/pages/LoadingPage";
import RestaurantsScreen from "./src/pages/RestaurantsPage";
import AccomodationPage from "./src/pages/AccomodationPage";
import BarsPage from "./src/pages/BarsPage";
import EventsPage from "./src/pages/EventsPage";
import MuseumPage from "./src/pages/MuseumPage";
const Stack = createStackNavigator();
export default function App() {
  return (
    <GlobalProvider>
      <NavigationContainer>
        <Stack.Navigator initialRouteName="LoadingPage">
          <Stack.Screen
            name="LoadingPage"
            component={LoadingPage}
            options={{ headerShown: false }}
          />
          <Stack.Screen
            name="Home"
            component={HomeScreen}
            options={{ headerShown: false }}
          />
          <Stack.Screen
            name="Details"
            component={DetailsScreen}
            options={{
              headerShown: false,

              // Add other header customization options here
            }}
          />
          <Stack.Screen
            name="Restaurants"
            component={RestaurantsScreen}
            options={{
              headerStyle: {
                backgroundColor: '#6C0B67A6',
                borderBottomLeftRadius: 20,
                borderBottomRightRadius: 20,
                height: 30,
              },
              headerTitleStyle: {
                display: 'none',
              },
              headerTintColor: 'white',
            }}
          />
          <Stack.Screen
            name="Accomodation"
            component={AccomodationPage}
            options={{
              headerShown: false,
          
              // Add other header customization options here
            }}
          />
          <Stack.Screen
            name="Bars"
            component={BarsPage}
            options={{
              headerStyle: {
                backgroundColor: '#6C0B67A6',
                borderBottomLeftRadius: 20,
                borderBottomRightRadius: 20,
                height: 30,
              },
              headerTitleStyle: {
                display: 'none',
              },
              headerTintColor: 'white',
            }}
          />
          <Stack.Screen
            name="Events"
            component={EventsPage}
            options={{
              headerShown: false,

              // Add other header customization options here
            }}
          />
          <Stack.Screen
            name="Museum"
            component={MuseumPage}
            options={{
              headerShown: false,

              // Add other header customization options here
            }}
          />
        </Stack.Navigator>
      </NavigationContainer>
    </GlobalProvider>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: "#fff",
    alignItems: "center",
    justifyContent: "center",
  },
});
