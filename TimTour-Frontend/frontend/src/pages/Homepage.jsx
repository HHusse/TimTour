import React from "react";
import { View, Text, Button } from "react-native";
import { useGlobalContext } from "../context/GlobalContext";
const HomeScreen = ({ navigation }) => {
  const { backendURL } = useGlobalContext();
  return (
    <View>
      <Text>{backendURL}</Text>
      <Button
        title="Go to Details"
        onPress={() => navigation.navigate("Details")}
      />
      <Button
        title="Go to svg"
        onPress={() => navigation.navigate("LoadingPage")}
      />
    </View>
  );
};

export default HomeScreen;
