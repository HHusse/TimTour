import { View, Text } from 'react-native'
import { useGlobalContext } from "../context/GlobalContext";
import React, { useEffect } from 'react'
import axios from 'axios';

const BarsPage = () => {
  const { backendURL } = useGlobalContext();
  
  useEffect(() => {
    axios.get(`${backendURL}/bars`)
      .then(response => {
        console.log('Bars data:', response.data);
      })
      .catch(error => {
        console.error('Error fetching bars:', error);
      });
  }, []);

  return (
    <View>
      <Text>BarsPage</Text>
    </View>
  )
}

export default BarsPage