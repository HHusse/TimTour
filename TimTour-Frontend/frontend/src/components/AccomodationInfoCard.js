import React from 'react';
import { View, Text, StyleSheet, Linking } from 'react-native';

const RestaurantInfoCard = ({ accomodation }) => {
 const handlePress = () => {
    Linking.openURL(accomodation.webSiteURL);
 };

 return (
    <View style={styles.container}>
      <View style={styles.titleContainer}>
        <Text style={styles.title}>{accomodation.name}</Text>
      </View>
      <View style={styles.infoContainer}>
        <Text style={styles.address}>Adress: {accomodation.address}</Text>
        <Text style={styles.phoneNumber}>Phone number: {accomodation.phoneNumber}</Text>
        <Text style={styles.stars}>Stars: {accomodation.stars} </Text>
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
 stars: {
   fontSize: 10,
   fontWeight: 'bold',
   color: '#FFFFFF',
 },
 websiteURL: {
    fontSize: 9,
    fontWeight: 'bold',
    color: '#FFFFFF',
 },
});

export default RestaurantInfoCard;