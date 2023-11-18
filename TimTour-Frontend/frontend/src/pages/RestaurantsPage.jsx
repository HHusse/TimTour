import { View, Text } from 'react-native'
import { useGlobalContext } from "../context/GlobalContext";
import React, { useEffect } from 'react'
import axios from 'axios';

const RestaurantsPage = () => {
  const { backendURL } = useGlobalContext();
  
  useEffect(() => {
    axios.get(`${backendURL}/restaurants`)
      .then(response => {
        console.log('Restaurants data:', response.data);
      })
      .catch(error => {
        console.error('Error fetching restaurants:', error);
      });
  }, []);

  return (
    <View>
      <Text>RestaurantsPage</Text>
    </View>
  )
}

export default RestaurantsPage