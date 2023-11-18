import React from "react";
import { View, Text, Button, Pressable, StyleSheet } from "react-native";

const DetailsScreen = ({ navigation }) => {
  return (
    <View>
      <Text>Details Screen</Text>
      <Button title="Go to Home" onPress={() => navigation.navigate("Home")} />
      <Button title="Ce plm coaie" />
      <Pressable
        style={styles.customButton}
        onPress={() => {
          // Handle button press
        }}
      >
        <Text style={styles.buttonText}>To another page</Text>
      </Pressable>
    </View>
  );
};

const styles = StyleSheet.create({
  customButton: {
    backgroundColor: "red",
  },
});
export default DetailsScreen;
