import React, { useEffect, useState } from 'react';
import { StyleSheet, View, Image, Text, TouchableOpacity } from 'react-native';
import { useGlobalContext } from "../context/GlobalContext";
import axios from 'axios';
import Navbar from "../components/Navbar"
import RestaurantInfoCard from "../components/RestaurantInfoCard"

const RestaurantsPage = () => {
 const { backendURL } = useGlobalContext();
 const [restaurantsData, setRestaurantsData] = useState([]);

 useEffect(() => {
    axios.get(`${backendURL}/restaurants`)
      .then(response => {
        console.log('Restaurants data:', response.data);
        setRestaurantsData(response.data);
      })
      .catch(error => {
        console.error('Error fetching restaurants:', error);
      });
 }, []);

 return (
    <View style={styles.container}>
      <View style={styles.imageContainer}>
        <Image
          source={require('../../assets/restaurantlefttop.png')}
          style={styles.image}
        />
      </View>
      {restaurantsData.map((restaurant, index) => (
        <RestaurantInfoCard key={restaurant.id || index} restaurant={restaurant} />
      ))}
    </View>
 );
};

const styles = StyleSheet.create({
 container: {
    flex: 1,
    flexDirection: 'column',
 },
  imageContainer: {
    paddingTop: 15,
    paddingLeft:15,
    flex: 1,
    justifyContent: 'center',
    alignItems: 'center',
    alignSelf: 'flex-start',
  },
  image: {
      width: 215,
      height: 60,
  },
});

export default RestaurantsPage;