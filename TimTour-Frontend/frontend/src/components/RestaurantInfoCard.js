import React from 'react';
import { View, Text, StyleSheet, Linking } from 'react-native';

const RestaurantInfoCard = ({ restaurant }) => {
 const handlePress = () => {
    Linking.openURL(restaurant.webSiteURL);
 };

 return (
    <View style={styles.container}>
      <View style={styles.titleContainer}>
        <Text style={styles.title}>{restaurant.name}</Text>
      </View>
      <View style={styles.infoContainer}>
        <Text style={styles.address}>Adresa: {restaurant.address}</Text>
        <Text style={styles.phoneNumber}>Telefon nr.: {restaurant.phoneNumber}</Text>
        <Text style={styles.websiteURL} onPress={handlePress}>WebSite</Text>
      </View>
    </View>
 );
};

const styles = StyleSheet.create({
 container: {
    margin: 10,
    padding: 10,
    borderWidth: 1,
    borderRadius: 5,
    backgroundColor: '#6C0B67A6',
 },
 titleContainer: {
    alignItems: 'flex-start',
    justifyContent: 'center',
 },
 title: {
    fontSize: 18,
    fontWeight: 'bold',
    color: '#FFFFFF',
 },
 infoContainer: {
    alignItems: 'flex-end',
 },
 address: {
    fontSize: 9,
    color: '#FFFFFF',
 },
 phoneNumber: {
    fontSize: 9,
    color: '#FFFFFF',
 },
 websiteURL: {
    fontSize: 9,
    fontWeight: 'bold',
    color: '#FFFFFF',
 },
});

export default RestaurantInfoCard;