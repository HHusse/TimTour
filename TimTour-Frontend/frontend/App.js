import { StatusBar } from "expo-status-bar";
import { StyleSheet, Text, View } from "react-native";
import { NavigationContainer } from "@react-navigation/native";
import { createStackNavigator } from "@react-navigation/stack";
import { GlobalProvider } from "./src/context/GlobalContext";
import HomeScreen from "./src/pages/Homepage";
import DetailsScreen from "./src/pages/DetailsPage";
import LoadingPage from "./src/pages/LoadingPage";
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
