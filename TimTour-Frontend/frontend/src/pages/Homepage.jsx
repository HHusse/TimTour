import React from "react";
import {
  View,
  ImageBackground,
  Text,
  TouchableOpacity,
  StyleSheet,
  Image,
} from "react-native";

const MyComponent = () => {
  return (
    <View style={styles.container}>
      {/* Image Background with Gray Filter */}
      <ImageBackground
        source={require("../../assets/CityImage.jpg")}
        style={styles.imageBackground}
      >
        {/* Overlay View with Text */}
        <View style={styles.overlay}>
          <Text style={styles.boldText}>TimTour</Text>
          <Text style={styles.normalText}>Your trip planning app</Text>
        </View>
      </ImageBackground>

      {/* Button */}
      <TouchableOpacity style={styles.button}>
        <Text style={styles.buttonText}>Schedule your day</Text>
      </TouchableOpacity>
      <View>
        <View style={styles.Buttoncontainer}>
          {/* First Row */}
          <View style={styles.row}>
            <TouchableOpacity
              style={styles.button}
              onPress={() => handleButtonPress(1)}
            >
              <Image
                source={require("../../assets/CityImage.jpg")}
                style={styles.Activityimage}
              />
            </TouchableOpacity>

            <TouchableOpacity
              style={styles.button}
              onPress={() => handleButtonPress(2)}
            >
              <Image
                source={require("../../assets/CityImage.jpg")}
                style={styles.Activityimage}
              />
            </TouchableOpacity>

            <TouchableOpacity
              style={styles.button}
              onPress={() => handleButtonPress(3)}
            >
              <Image
                source={require("../../assets/CityImage.jpg")}
                style={styles.Activityimage}
              />
            </TouchableOpacity>
          </View>

          {/* Second Row */}
          <View style={styles.row}>
            <TouchableOpacity
              style={styles.button}
              onPress={() => handleButtonPress(4)}
            >
              <Image
                source={require("../../assets/CityImage.jpg")}
                style={styles.Activityimage}
              />
            </TouchableOpacity>

            <TouchableOpacity
              style={styles.button}
              onPress={() => handleButtonPress(5)}
            >
              <Image
                source={require("../../assets/CityImage.jpg")}
                style={styles.Activityimage}
              />
            </TouchableOpacity>
          </View>
        </View>
      </View>
    </View>
  );
};

const styles = StyleSheet.create({
  container: {
    height: "30%",
    justifyContent: "flex-start", // Align items at the top
    alignItems: "center",
  },
  imageBackground: {
    width: "100%",
    height: "100%", // Adjust the height as needed
    resizeMode: "cover",
  },
  overlay: {
    height: "100%",
    justifyContent: "center",
    alignItems: "center",
    backgroundColor: "rgba(128, 128, 128, 0.6)",
  },
  boldText: {
    fontSize: 24,
    fontWeight: "bold",
    color: "white",
  },
  normalText: {
    fontSize: 16,
    color: "white",
  },
  button: {
    marginTop: 20,
    backgroundColor: "#6C0B67A6",
    padding: 15,
    borderRadius: 20,
    width: "70%",
    justifyContent: "center",
    alignItems: "center",
  },
  buttonText: {
    color: "white",
    fontSize: 16,
    fontWeight: "bold",
  },
  Buttoncontainer: {
    flex: 1,
    padding: 16,
    justifyContent: "center",
    alignItems: "center",
  },
  row: {
    flexDirection: "row",
    marginBottom: 16,
  },
  Activityimage: {
    width: "100%",
    height: "100%",
    resizeMode: "cover",
  },
});

export default MyComponent;
