import React from "react";
import {
  View,
  ImageBackground,
  Text,
  TouchableOpacity,
  StyleSheet,
  Image,
} from "react-native";

const MyComponent = ({ navigation }) => {
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
              style={styles.ActivityButton}
              onPress={() => navigation.navigate("Restaurants")}
            >
              <Image
                source={require("../../assets/group_restaurants.png")}
                style={styles.Activityimage}
              />
            </TouchableOpacity>

            <TouchableOpacity
              style={styles.ActivityButton}
              onPress={() => navigation.navigate("Accomodation")}
            >
              <Image
                source={require("../../assets/grup_accomodation.png")}
                style={styles.Activityimage}
              />
            </TouchableOpacity>

            <TouchableOpacity
              style={styles.ActivityButton}
              onPress={() => navigation.navigate("Bars")}
            >
              <Image
                source={require("../../assets/group_drinks.png")}
                style={styles.Activityimage}
              />
            </TouchableOpacity>
          </View>

          {/* Second Row */}
          <View style={styles.row}>
            <TouchableOpacity
              style={styles.ActivityButton}
              onPress={() => navigation.navigate("Events")}
            >
              <Image
                source={require("../../assets/group_events.png")}
                style={styles.Activityimage}
              />
            </TouchableOpacity>

            <TouchableOpacity
              style={styles.ActivityButton}
              onPress={() => navigation.navigate("Museum")}
            >
              <Image
                source={require("../../assets/group_placetovisit.png")}
                style={styles.Activityimage}
              />
            </TouchableOpacity>
          </View>
        </View>
      </View>
      <View style={styles.FooterContainer}>
        {/* Image Background covering the full view */}
        <ImageBackground
          source={require("../../assets/wave.png")}
          style={styles.imageBackground}
        >
          {/* Overlay View with Text */}
          <View style={styles.footerOverlay}>
            <Text style={styles.overlayText}>Useful Tools</Text>
          </View>

          {/* Three Buttons with Images */}
          <View style={styles.footerButtonContainer}>
            <TouchableOpacity
              style={styles.footerButton}
              onPress={() => handleButtonPress(1)}
            >
              <Image
                source={require("../../assets/group_tanslator.png")}
                style={styles.footerButtonImage}
              />
            </TouchableOpacity>

            <TouchableOpacity
              style={styles.footerButton}
              onPress={() => handleButtonPress(2)}
            >
              <Image
                source={require("../../assets/currency_exchange.png")}
                style={styles.footerButtonImage}
              />
            </TouchableOpacity>

            <TouchableOpacity
              style={styles.footerButton}
              onPress={() => handleButtonPress(3)}
            >
              <Image
                source={require("../../assets/group_public_transport.png")}
                style={styles.footerButtonImage}
              />
            </TouchableOpacity>
          </View>
        </ImageBackground>
      </View>
    </View>
  );
};

const styles = StyleSheet.create({
  container: {
    height: "20%",
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
    paddingTop: 40,
    justifyContent: "center",
    alignItems: "center",
  },
  row: {
    flexDirection: "row",
    marginBottom: 16,
    paddingTop: 60,
    gap: 90,
  },
  Activityimage: {
    width: 110,
    height: 140,
    borderRadius: 20,
    resizeMode: "cover",
  },
  ActivityButton: {
    marginTop: 20,
    padding: 15,
    borderRadius: 20,
    width: 30,
    height: 50,
    justifyContent: "center",
    alignItems: "center",
  },
  FooterContainer: {
    width: "100%",
    paddingTop: 20,
  },
  footerOverlay: {},
  overlayText: {},
  footerButtonContainer: { width: 30, height: 30 },
  footerButton: {},
  footerButtonImage: {},
});

export default MyComponent;
